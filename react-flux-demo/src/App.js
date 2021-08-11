
import './App.css';
import { ProductDashBoard } from './flux/ProductDashboard';

function App(props) {
  return (
    <div className="App">
    <ProductDashBoard dispatcher={props.dispatcher} store={props.productStore}></ProductDashBoard>
    </div>
  );
}

export default App;
