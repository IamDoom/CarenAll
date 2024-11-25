const path = require('path');
const webpack = require('webpack');
const ReactRefreshWebpackPlugin = require('@pmmmwh/react-refresh-webpack-plugin');


module.exports = {
    mode: 'development', // Ensure you are in development mode for HMR
    entry: './clientapp/src/index.js',  // entry point for React
    output: {
        path: path.resolve(__dirname, 'wwwroot/js'),  // output to wwwroot/js folder
        filename: 'bundle.js',  // bundle file name
        clean: true,
    },
    watch: true,
    module: {
        rules: [
            {
                test: /\.jsx?$/,  // Match JavaScript and JSX files
                exclude: /node_modules/,
                use: {
                    loader: 'babel-loader',
                    options: {
                        presets: ['@babel/preset-env', '@babel/preset-react'],
                        plugins: [
                            'react-refresh/babel', // Enable React Refresh for HMR
                        ],
                    },
                },
            },
        ],
    },
    resolve: {
        extensions: ['.js', '.jsx'],  // Automatically resolve .js and .jsx files
    },
    devServer: {
        static: [
            {
                directory: path.resolve(__dirname, 'wwwroot'),  // Primary static files directory
            },
            {
                directory: path.resolve(__dirname, 'clientapp'),  // Additional static files directory
            }
        ],
        hot: true,  // Enable Hot Module Replacement (HMR)
        client: {
            logging: 'info',  // Enable client-side logging
        },
    },
    plugins: [
        new webpack.HotModuleReplacementPlugin(), // Enable HMR
        new ReactRefreshWebpackPlugin(),
    ],
};