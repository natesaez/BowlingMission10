import type { bowler } from "./types/bowler";
import { useEffect, useState } from 'react'

function BowlerList () {

const [bowlers, setBowlers] = useState<bowler[]>([]);

useEffect(() => {

const fetchBowler = async () => {
    const response = await fetch("https://localhost:7000/api/Bowlers");
    const data = await response.json();
    setBowlers(data);
};
fetchBowler();
}, []);




    return (
        <>
            <h1>Bowler info</h1>
            <table>
                <thead>
                    <tr>
                        <th>First name</th>
                        <th>Middle initial</th>
                        <th>Last Name</th>
                        <th>Team</th>
                        <th>Address</th>
                        <th>City</th>
                        <th>State</th>
                        <th>Zip</th>
                        <th>Phone Number</th>
                    </tr>
                </thead>

                <tbody>
                    {
                        bowlers.map((f) => (
                            <tr key={f.bowlerId}>
                                <td>{f.bowlerFirstName}</td>
                                <td>{f.bowlerMiddleInit}</td>
                                <td>{f.bowlerLastName}</td>
                                <td>{f.teamName}</td>
                                <td>{f.bowlerAddress}</td>
                                <td>{f.bowlerCity}</td>
                                <td>{f.bowlerState}</td>
                                <td>{f.bowlerZip}</td>
                                <td>{f.bowlerPhoneNumber}</td>
                            </tr>
                        ))
                    }
                </tbody>
            </table>
        </>
    );
}

export default BowlerList;