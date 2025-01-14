import React, { useEffect, useState } from "react";
import '/wwwroot/css/CarCard.css'



const GetCarCards = () => {
    const [cars, setCars] = useState([]);

    useEffect(() => {
        fetch("/GetAllVehicles")
            .then(response => response.json())
            .then(data => {
                console.log("Fetched Data:", data); // Debug: Log fetched JSON data
                setCars(data);
            })
            .catch(error => console.error("Error fetching cars:", error));
    }, []);

    const showCalendar = (carId) => {
        
        console.log(`Show calendar for car ID: ${carId}`);
    };

    return (
        <div className="scrollable-cards">
            {Array.isArray(cars) && cars.length > 0 ? (
                cars.map((car, index) => {
                    console.log("Rendering car:", car); // Debug: Log each car being rendered
                    return (
                        <div className="card" key={car.id || `car-${index}`}>
                            <h3>{car.merk} {car.type}</h3>
                            <p>Kleur: {car.kleur}</p>
                            <p>Kenteken: {car.kenteken}</p>
                            <button className="btn-lease" onClick={() => showCalendar(car.Id)}>Bekijk specificaties</button>
                        </div>
                    );
                })
            ) : (
                <p>No cars available</p>
            )}
        </div>
    );
}; 

export default GetCarCards;