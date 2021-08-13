import registerServiceWorker from './registerServiceWorker';

import React from 'react';
import ReactDOM from 'react-dom';
import { createStore } from 'redux';
import { Provider } from 'react-redux';
import tasks from './reducers';
import {AppWrapper} from './App';
import './index.css';

const store = createStore(tasks);

ReactDOM.render(
  <Provider store={store}>
  <AppWrapper></AppWrapper>
  </Provider>,
  document.getElementById('root')
);

registerServiceWorker();
