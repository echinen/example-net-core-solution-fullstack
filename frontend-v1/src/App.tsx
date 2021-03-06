import React, { Component } from "react";
import logo from "./logo.svg";
import "./App.css";
import axios from 'axios';
import { Header, Icon } from 'semantic-ui-react'

class App extends Component {
  state = {
    values: [],
  };

  componentDidMount() {
    axios.get('http://localhost:5000/api/values')
    .then(response => {
      this.setState({
        values: response.data
      });
    })
  }

  render() {
    return (
      <div>
        <Header as='h2'>
          <Icon name='plug'/>
          <Header.Content>Uptime Guarantee</Header.Content>
        </Header>
          <ul>
            {this.state.values.map((value:any) => (
              <li key={value.id}>{value.name}</li>
            ))}
          </ul>
        </div>
    );
  }
}

export default App;