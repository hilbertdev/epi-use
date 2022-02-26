import React, { useEffect, useState } from "react";
import "./App.css";
import axios from "axios";
import { List, ListItem, ListList } from "semantic-ui-react";
import ParentChild from "./Interface /Organisation";
import IEmployee from "./Interface /Employee";

function App() {
  const [employees, setEmployees] = useState([]);
  useEffect(() => {
    axios
      .get("http://localhost:5000/api/Employees/OrganisationalStructure")
      .then((response) => {
        console.log(response.data);
        setEmployees(response.data);
      });
  }, []);
  return (
    <div className="App">
      <header className="App-header">
        <List>
          {employees.map((employee: ParentChild) => (
            <ListItem key={employee.manager.employeeId}>
              <List.Content>
                <List.Header>
                  {employee.manager.roleDescriptionType} - {employee.manager.name} {employee.manager.surname}
                </List.Header>
                <ListList>
                </ListList>
              </List.Content>
            </ListItem>
          ))}
        </List>
      </header>
    </div>
  );
}

export default App;
