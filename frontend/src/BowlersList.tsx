import type { bowler } from "./types/bowler";
import { useState } from 'react'

function BowlerList () {

const [bowlers, setBowlers] = useState<bowler[]>([]);

const fetchBowler = async () => {
    const response = await fetch("http://localhost:6000/api/Bowlers");
    const data = await response.json();
    setBowlers(data);
}

fetchBowler();

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
                                <td>{f.teamId}</td>
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