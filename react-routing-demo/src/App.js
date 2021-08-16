import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import { HomeComponent } from './home';
import { ContactsComponent } from './contacts';
import { TopicsComponent } from './topics';


class App extends Component {
  render() {
    return (
      <Router>
      <div>
        <ul>
          <li>
            <Link to="/">Home</Link>
          </li>
          <li>
            <Link to="/contacts">Contact</Link>
          </li>
          <li>
            <Link to="/topics">Topics</Link>
          </li>
        </ul>

        <hr />

        <Route exact path="/" component={HomeComponent} />
        <Route path="/contacts" component={ContactsComponent} />
        <Route path="/topics" component={TopicsComponent} />
      </div>
    </Router>
    );
  }
}

export default App;
