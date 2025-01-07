import React, { useEffect, useState } from "react";
import '/wwwroot/css/CarCard.css'

const GetCarCards = () => {
    const [cars, setCars] = useState([]);

    useEffect(() => {
        // Fetch car data from the API
        fetch("/GetAllVehicles")
            .then(response => response.json())
            .then(data => setCars(data))
            .catch(error => console.error("Error fetching cars:", error));
    }, []);

    const showCalendar = (carId) => {
        // Handle the "Lease Now" button click
        console.log(`Show calendar for car ID: ${carId}`);
    };

    return (
        <div className="scrollable-cards">
            {cars.map(car => (
                <div className="card" key={car.Id} onClick={() => showCalendar(car.Id)}>
                    <h3>{car.Merk} {car.Type}</h3>
                    <p>Kleur: {car.Kleur}</p>
                    <p>Kenteken: {car.Kenteken}</p>
                    <button className="btn-lease">Lease Now</button>
                </div>
            ))}
        </div>
    );
}; 

export default GetCarCards;