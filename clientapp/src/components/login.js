﻿import React from 'react';
import '/wwwroot/css/authStyles.css';

function Login({ onChangeView, setError }) {
    const handleLogin = async (e) => {
        e.preventDefault();
        
        const response = await fetch('/api/login');
        if (response.ok) {
            window.location.href = '/index';
        } else {
            setError('Invalid username or password');
        }
    };

    return (
        <div>
            <h2>Login</h2>
            <form className="auth-form" onSubmit={handleLogin}>
                <div>
                    <label htmlFor="username">Username:</label>
                    <input type="text" id="username" name="username" />
                </div>
                <div>
                    <label htmlFor="password">Password:</label>
                    <input type="password" id="password" name="password" />
                </div>
                <button type="submit">Log In</button>
            </form>

            <div className="auth-button-group">
                <button
                    type="button"
                    className="secondary"
                    onClick={() => onChangeView('forgotPassword')}
                >
                    Forgot Password?
                </button>
                <button
                    type="button"
                    className="secondary"
                    onClick={() => onChangeView('signup')}
                >
                    Sign Up
                </button>
            </div>
        </div >
    );
}

export default Login;