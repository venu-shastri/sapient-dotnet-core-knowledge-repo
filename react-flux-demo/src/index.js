import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import {dispatchInstance} from './flux/dispatcher'
import {productStoreInstance} from './flux/productsStore'
import {MicroEvent} from './flux/microEvents'

const observableProductStore=MicroEvent.mixin(productStoreInstance);

ReactDOM.render(
  <React.StrictMode>
    <App dispatcher={dispatchInstance} productStore={observableProductStore} />
  </React.StrictMode>,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
