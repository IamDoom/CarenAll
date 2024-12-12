import React, { useState } from 'react';
import '/wwwroot/css/authStyles.css';

// Individual user type forms for each case
const SignUpParticulier = ({ onChangeView, formData, handleChange }) => (
    <div className="auth-form">
        <div className="form-field">
            <label htmlFor="username">Gebruikersnaam</label>
            <input
                type="text"
                id="username"
                name="username"
                value={formData.username || ''}
                onChange={handleChange}
                placeholder="Username"
            />
        </div>
        <div className="form-field">
            <label htmlFor="email">Email</label>
            <input
                type="email"
                id="email"
                name="email"
                value={formData.email || ''}
                onChange={handleChange}
                placeholder="Email"
            />
        </div>
        <div className="form-field">
            <label htmlFor="phoneNumber">Telefoonnummer</label>
            <input
                type="text"
                id="phoneNumber"
                name="phoneNumber"
                value={formData.phoneNumber || ''}
                onChange={handleChange}
                placeholder="Phone Number"
            />
        </div>
    </div>
);

const SignUpBedrijf = ({ formData, handleChange }) => (
    <div className="auth-form">
        <div className="form-field">
            <label htmlFor="companyName">Bedrijf Naam</label>
            <input
                type="text"
                id="companyName"
                name="companyName"
                value={formData.companyName || ''}
                onChange={handleChange}
                placeholder="Company Name"
            />
        </div>
        <div className="form-field">
            <label htmlFor="address">Adres</label>
            <input
                type="text"
                id="address"
                name="address"
                value={formData.address || ''}
                onChange={handleChange}
                placeholder="Address"
            />
        </div>
        <div className="form-field">
            <label htmlFor="kvkNumber">Kvk Nummer</label>
            <input
                type="text"
                id="kvkNumber"
                name="kvkNumber"
                value={formData.kvkNumber || ''}
                onChange={handleChange}
                placeholder="Kvk Number"
            />
        </div>
    </div>
);

const SignUpZakelijkeKlant = ({ formData, handleChange }) => (
    <div className="auth-form">
        <div className="form-field">
            <label htmlFor="username">Gebruikers Naam</label>
            <input
                type="text"
                id="username"
                name="username"
                value={formData.username || ''}
                onChange={handleChange}
                placeholder="Username"
            />
        </div>
        <div className="form-field">
            <label htmlFor="firstName">Voornaam</label>
            <input
                type="text"
                id="firstName"
                name="firstName"
                value={formData.firstName || ''}
                onChange={handleChange}
                placeholder="First Name"
            />
        </div>
        <div className="form-field">
            <label htmlFor="lastName">Achternaam</label>
            <input
                type="text"
                id="lastName"
                name="lastName"
                value={formData.lastName || ''}
                onChange={handleChange}
                placeholder="Last Name"
            />
        </div>
        <div className="form-field">
            <label htmlFor="email">Email Adres</label>
            <input
                type="email"
                id="email"
                name="email"
                value={formData.email || ''}
                onChange={handleChange}
                placeholder="Email Address"
            />
        </div>
        <div className="form-field">
            <label htmlFor="companyID">Bedrijf-ID</label>
            <input
                type="text"
                id="companyID"
                name="companyID"
                value={formData.companyID || ''}
                onChange={handleChange}
                placeholder="Company ID"
            />
        </div>
    </div>
);

const PasswordComponent = ({ formData, handleChange, handleSubmitPassword }) => (
    <div className="auth-form">
        <div className="form-field">
            <label htmlFor="password">Wachtwoord</label>
            <input
                type="password"
                id="password"
                name="password"
                value={formData.password || ''}
                onChange={handleChange}
                placeholder="Password"
            />
        </div>
        <button type="submit" onClick={handleSubmitPassword}>registreer</button>
    </div>
);

function SignUp({ onBack, onChangeView }) {
    const [formData, setFormData] = useState({});
    const [userType, setUserType] = useState('particulier');
    const [errorMessage, setErrorMessage] = useState('');
    const [showPasswordForm, setShowPasswordForm] = useState(false);

    const handleChange = (event) => {
        const { name, value } = event.target;
        setFormData((prevData) => ({
            ...prevData,
            [name]: value,
        }));
    };

    const handleSubmitPassword = async (event) => {
        event.preventDefault();
        setErrorMessage('');

        try {
            const response = await fetch('/api/register', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify({ ...formData, password: formData.password }),
            });
            const result = await response.json();
            if (response.ok) {
                alert('Registration successful!');
            } else {
                setErrorMessage(result.message || 'An error occurred during registration.');
            }
        }
        catch (error) {
            setErrorMessage('Network error, please try again later.');
        }
    };

    const handleSubmit = async (event) => {
        event.preventDefault();
        setErrorMessage('');

        let endpoint = '';
        if (userType === 'particulier') {
            endpoint = '/api/particulier-pre-registration';
        } else if (userType === 'bedrijf') {
            endpoint = '/api/bedrijf-pre-registration';
        } else if (userType === 'zakelijkeKlant') {
            endpoint = '/api/zakelijke-klant-pre-registration';
        }

        try {
            const response = await fetch(endpoint, {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify(formData),
            });

            const result = await response.json();
            if (response.ok) {
                setShowPasswordForm(true);
            } else {
                setErrorMessage(result.message || 'An error occurred during registration.');
            }
        } catch (error) {
            setErrorMessage('Network error, probeer het later opnieuw.');
        }
    };

    return (
        <div className="auth-container">
            <h2>Sign Up</h2>
            <div className="radio-button-group">
                <input
                    type="radio"
                    id="particulier"
                    name="userType"
                    checked={userType === 'particulier'}
                    onChange={() => setUserType('particulier')}
                />
                <label htmlFor="particulier">Particulier</label>

                <input
                    type="radio"
                    id="bedrijf"
                    name="userType"
                    checked={userType === 'bedrijf'}
                    onChange={() => setUserType('bedrijf')}
                />
                <label htmlFor="bedrijf">Bedrijf</label>

                <input
                    type="radio"
                    id="zakelijkeKlant"
                    name="userType"
                    checked={userType === 'zakelijkeKlant'}
                    onChange={() => setUserType('zakelijkeKlant')}
                />
                <label htmlFor="zakelijkeKlant">Zakelijke klant</label>
            </div>

            {userType === 'particulier' && <SignUpParticulier formData={formData} handleChange={handleChange} />}
            {userType === 'bedrijf' && <SignUpBedrijf formData={formData} handleChange={handleChange} />}
            {userType === 'zakelijkeKlant' && <SignUpZakelijkeKlant formData={formData} handleChange={handleChange} />}

            {errorMessage && <div className="error-message">{errorMessage}</div>}

            {showPasswordForm ? (
                <PasswordComponent formData={formData} handleChange={handleChange} handleSubmitPassword={handleSubmitPassword} />
            ) : (
                <button type="submit" onClick={handleSubmit}>Verder</button>
            )}

            <div className="auth-button-group">
                <button
                    type="button"
                    className="secondary"
                    onClick={() => onChangeView('login')}
                >
                    Log in
                </button>

                <button
                    type="button"
                    className="secondary"
                    onClick={() => onChangeView('forgotPassword')}
                >
                    Forgot Password
                </button>
            </div>
        </div>
    );
}

export default SignUp;
