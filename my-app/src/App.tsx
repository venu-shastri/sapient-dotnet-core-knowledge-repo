import React from 'react';
//import Header from './components/Header/Header'
import './App.css';
//import Counter from './components/counter/counter';
import { AppContainer } from "./styles"
import {Column} from './components/column/column'
import {Card} from './components/card/card'
import {AddNewItem} from './components/addNewItem/AddNewItem'
function App() {
  return (
    // <div className="App">
    //   <Header></Header>
    //   <Counter></Counter>
    //   <AppContainer></AppContainer>
    // </div>
    <AppContainer>
        <Column text="To Do">
          <Card text="Generate app scaffold" />
        </Column>
        <Column text="In Progress">
          <Card text="Learn Typescript" />
        </Column>
        <Column text="Done">
          <Card text="Begin to use static typing" />
        </Column>
        <AddNewItem toggleButtonText="+ Add another list" onAdd={console.log} />
    </AppContainer>
  );
}

export default App;
