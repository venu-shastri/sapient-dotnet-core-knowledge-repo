import React from 'react';
import { Greeter } from './Greeter';
import './App.css';
import { Clock } from './Clock';

function App() {
  return (
    <div className="App">
    <Greeter message="Hello TypeScript Functional Component"/>
    <Clock></Clock>
    </div>
  );
}

export default App;
