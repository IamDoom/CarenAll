const path = require('path');
const webpack = require('webpack');
const ReactRefreshWebpackPlugin = require('@pmmmwh/react-refresh-webpack-plugin');


module.exports = {
    mode: 'development',
    entry: {
        privatecustomer: './clientapp/src/PrivateCustomerApp.js', //tussentijds tot de index wordt gefixed
        login: './clientapp/src/LoginIndex.js', // Entry for the Login page (Login SPA)
        app: './clientapp/src/index.js',         // Entry for the main app
    },
    output: {
        path: path.resolve(__dirname, 'wwwroot/js'), // Output both bundles to the same directory
        filename: '[name].bundle.js', // Use [name] to generate separate bundles (login.bundle.js and app.bundle.js)
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
            {
                test: /\.css$/, // Add a CSS loader
                use: ['style-loader', 'css-loader'], // Ensure CSS files are loaded
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
                publicPath: '/clientapp',
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