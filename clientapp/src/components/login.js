import React from 'react';
import '/wwwroot/css/authStyles.css';

function Login({ onChangeView, setError }) {
    const handleLogin = async (e) => {
        e.preventDefault();

        // Collect form data
        const formData = new FormData(e.target);
        const data = {
            Username: formData.get('Username'),
            PasswordHash: formData.get('PasswordHash'), // Send plain password or hash it if required
        };
        console.log(data);
        try {
            // Send POST request to the server
            const response = await fetch('/api/login', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify(data),
            });

            if (response.ok) {
                const redirectUrl = await response.text(); // Extract URL from the response
                window.location.href = redirectUrl; // Redirect the user
            } else {
                setError('Invalid username or password');
            }
        } catch (error) {
            console.error('Login error:', error);
            setError('An error occurred. Please try again later.');
        }
    };

    return (
        <div>
            <h2>Login</h2>
            <form className="auth-form" onSubmit={handleLogin}>
                <div className="form-field">
                    <label htmlFor="username">Username:</label>
                    <input type="text" id="username" name="Username" required />
                </div>
                <div className="form-field">
                    <label htmlFor="password">Password:</label>
                    <input type="password" id="password" name="PasswordHash" required />
                </div>
                <button className="submit" type="submit">Log In</button>
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