import React, { useState, useEffect } from "react";

const ProfileCard = () => {
    const [userData, setUserData] = useState(null); // State to store user data
    const [loading, setLoading] = useState(true); // State to manage loading

    useEffect(() => {
        // Fetch user data when the component is mounted
        fetch("/privatecustomer/getprivateinfo")
            .then((response) => {
                if (!response.ok) {
                    throw new Error("Failed to fetch user info");
                }
                return response.json();
            })
            .then((data) => {
                setUserData(data); // Set the retrieved user data
                setLoading(false); // Stop loading
            })
            .catch((error) => {
                console.error("Error fetching user info:", error);
                setLoading(false);
            });
    }, []); // Empty dependency array ensures this runs once when the component is mounted

    if (loading) {
        return <div>Loading...</div>; // Show a loading message while data is being fetched
    }

    if (!userData) {
        return <div>No user data available.</div>; // Handle case where no user data is returned
    }

    return (
        <div className="account-card">
            <h2>Account Info</h2>
            <p>
                <strong>Name:</strong> {userData.firstName} {userData.lastName}
            </p>
            <p>
                <strong>Email:</strong> {userData.email}
            </p>
            <p>
                <strong>Phone Number:</strong> {userData.phoneNumber}
            </p>
            <button className="btn-action" onClick={() => alert("Messages clicked!")}>
                Messages
            </button>
            <button className="btn-action" onClick={() => alert("Change Profile clicked!")}>
                Change Profile
            </button>
        </div>
    );
};

export default ProfileCard;