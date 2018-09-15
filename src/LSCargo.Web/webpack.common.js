const path = require('path');
const webpack = require('webpack');
const UglifyJsPlugin = require('uglifyjs-webpack-plugin');
const MiniCssExtractPlugin = require('mini-css-extract-plugin');
const StyleLintPlugin = require('stylelint-webpack-plugin');

module.exports = {
    entry: {
        index: [
            __dirname + '/frontend/index.js',
            __dirname + '/frontend/index.scss',
        ],
    },
    output: {
        filename: '[name].js',
        path: path.join(__dirname, '/wwwroot/public'),
        publicPath: '/wwwroot/public/',
    },
    resolve: {
        extensions: ['.ts', '.tsx', '.js', '.jsx', '.json', '.scss'],
        alias: {
            'jquery.validate': 'jquery-validation/dist/jquery.validate',
            jquery: 'jquery/dist/jquery.min',
        },
    },
    module: {
        rules: [
            {
                enforce: 'pre',
                test: /\.(js|jsx)$/,
                exclude: /node_modules/,
                loader: 'source-map-loader',
            },
            {
                test: /\.(js|jsx)$/,
                exclude: /node_modules/,
                loader: 'babel-loader',
                query: {
                    presets: ['env'],
                },
            },
            {
                test: /\.(sa|sc|c)ss$/,
                use: [MiniCssExtractPlugin.loader, 'css-loader', 'postcss-loader', 'sass-loader'],
            },
            {
                test: /\.(woff(2)?|ttf|eot|svg)(\?v=\d+\.\d+\.\d+)?$/,
                use: [
                    {
                        loader: 'file-loader',
                        options: {
                            name: '[name].[ext]',
                            outputPath: 'font/',
                        },
                    },
                ],
            },
        ],
    },
    devtool: 'none',
    plugins: [
        new webpack.ProvidePlugin({
            $: 'jquery',
            jQuery: 'jquery',
        }),
        new StyleLintPlugin({
            files: 'frontend/**/*.s?(a|c)ss',
        }),
        new MiniCssExtractPlugin({
            filename: '[name].css',
        }),
    ],
    optimization: {
        minimizer: [
            new UglifyJsPlugin({
                cache: true,
                parallel: true,
                sourceMap: true, // set to true if you want JS source maps
            }),
        ],
        splitChunks: {
            cacheGroups: {
                commons: {
                    test: /[\\/]node_modules[\\/]/,
                    name: "vendors",
                    chunks: "all"
                }
            }
        },
    },
};
