import './App.css';
import {Greeter} from './Greeter'
import {GreeterClass} from './GreeterClass'
import {Clock} from './Clock'
import { ProductSearchContainer } from './products/ProductSearchContainer';
function App() {
  return (
    <div className="App">
     <Greeter message="Hello From App Component"></Greeter>
     <GreeterClass message="Hello From Class Component"></GreeterClass>
     <Clock></Clock>
     <ProductSearchContainer></ProductSearchContainer>
     
    </div>
  );
}

export default App;
