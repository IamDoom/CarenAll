const path = require('path');

module.exports = {
    entry: './clientapp/src/index.js',  // entry point for React
    output: {
        path: path.resolve(__dirname, 'wwwroot/js'),  // output to wwwroot folder
        filename: 'bundle.js',  // bundle name
    },
    module: {
        rules: [
            {
                test: /\.jsx?$/,
                exclude: /node_modules/,
                use: {
                    loader: 'babel-loader',
                    options: {
                        presets: ['@babel/preset-env', '@babel/preset-react'],
                    },
                },
            },
        ],
    },
    resolve: {
        extensions: ['.js', '.jsx'],  // resolve both JS and JSX files
    },
    devServer: {
        contentBase: path.resolve(__dirname, 'wwwroot'),
        publicPath: '/js/',
        hot: true,
    }
};