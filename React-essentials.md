<<<<<<< HEAD
#### DOM

---

- The DOM in HTML stands for Document Object Model. It is an in-memory representation of HTML and is tree-structured.
- The Document Object Model is the API for HTML and even XML documents such as SVG images.

- The DOM document consists of a hierarchical tree of nodes (https://developer.mozilla.org/en-US/docs/Web/API/Node), and the node interface allows access not just to the document but to each element
- DOM manipulation is the core of modern interactive web pages and can dynamically change the content of a web page

####  React Virtual DOM Under the Hood

---

> It’s crucial that the actual DOM tree-structured manipulation be as quick as possible. For example, say we have a product page, and we want to update the first item of our product’s list. Most JavaScript frameworks would update the entire list just to update one item, which may contain hundreds of items. Most modern web pages hold large DOM structures, and this behavior taxes the user too much, resulting in slower-loading HTML pages.
>
> The **virtual DOM (VDOM)** is a programming concept where an ideal, or virtual, representation of a UI is kept in memory and synced with the “real” DOM by a library such as **ReactDOM**. This process is called **reconciliation**. The React VDOM’s aim is to
> speed up this process.
>
> React determines what changes to make to the actual DOM based on the React element representation and do the changes in the background inside a virtual DOM .Then it commits only needed changes to the actual user’s DOM (browser). The
> reason behind this process is to speed up performance
>
> React holds a copy of the HTML DOM (that’s the virtual DOM). Once a change is needed, React first makes the change to the virtual DOM, and it then syncs the actual HTML DOM, avoiding the need to update the entire HTML DOM, which speeds up the process.
>
> For example, when we render a JSX element, every single virtual DOM object gets updated. This process of updating the entire virtual DOM instead of the actual HTML DOM is faster. In the **reconciliation** process, React needs to figure out which objects changed, and this process is called **diffing**. Then React updates only the objects in the real HTML DOM that need to be changed instead of the entire DOM tree.



```html
<html>
<head>
	<meta charSet="utf-8">
	<title>Hello world</title>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/react/17.0.0/umd/react.production.min.js"></script>
	<script src="https://unpkg.com/react-dom@17.0.0/umd/react-dom.production.min.js"></script>
	<script src="https://unpkg.com/@babel/standalone/babel.min.js"></script>
    </head>
    <body>
    <div id="app"></div>
        <script type="text/babel">
        ReactDOM.render(
        <h1>Hello World</h1>,
        document.getElementById('app')
        );
		</script>
        
    </body>
</html>
```

##### Why Should You Integrate TypeScript into Your React Project?

----

> You can write React code using JavaScript (JS) or TypeScript (TS).

- TypeScript is an OOP language; JavaScript is a scripting language.
-  TypeScript uses static typing following the ECMAScript specification.
-  TypeScript support modules



##### React Template Starter Project Options

----

- Most popular template for creating a React app is the Create-React-App (CRA) project (https://github.com/facebook/create-react-app).
  - It provides a boilerplate project, and you can be up and running quickly with many of the necessary tools and library that are standards when building a top-grade React application.
  - CRA has already made some decisions . For example, the build tool is a tool called Webpack over Rollup or Parcel. Task Runners is set up with NPM scripts over other tools such as Gulp. CSS, JS, and Jest are used as the defaults.
- **React Eco System**
  - Type checker: TypeScript
  - Preprocessors: Sass/SCSS
  -  State management: Redux Toolkit/Recoil
  - CSS framework: Material-UI / Bootstarp
  -  Components: Styled Components
  -  Router: React Router
  -  Unit testing: Jest and Enzym + Sinon
  -  E2E testing: Jest and Puppeteer
  -  Linter: ESLint and Prettier
  - Other useful libraries: Lodash, Moment, Classnames, Serve, reactsnap,
    React-Helmet, Analyzer Bundle
- Prerequisites
  - Install **Node** and **NPM**
  - Install Yarn/NPM 
    - npm install --global yarn



##### Create-React-App with TypeScript

---



```typescript
$ yarn create react-app my-app --template typescript
$ cd my-app
$ yarn start

//add the following types for TS so that Webpack knows how to handle .tsx file types and bundle them and so they can be included as static assets in our project.
$ yarn add -D typescript @types/node @types/react @types/react-dom @types/jest @typescript-eslint/scope-manager
```

##### React Project Folder Structure

---

- src/components
-  src/features
-  src/layout
-  src/pages
- src/redux

##### Generate Templates

----

You can generate your project templates using the generate-react-cli project in React. To install

```
npx generate-react-cli component Header
```



##### React components

React components enables by breaking down a complex UI into small, stand-alone pieces. In fact, the heart of React
is nothing more than a compilation of components working together in harmony. 

> Components let you split the UI into independent, reusable pieces, and think about each piece in isolation
>
> —React.org docs, https://reactjs.org/docs/components-and-props.html

##### Types of components.

---

- Functional components
- Class components
-  Factory components

##### Classification

---

- JavaScript (JS) functions and class components
- TypeScript (TS) functions and class components
-  Exotic components such as factory components
-  Complex TS factory components
- React.PureComponent versus React.Component



##### Functional Component

---

> Function components (also called functional stateless components) are nothing more than JavaScript functions

```javascript
<div id="app"></div>
<script type="text/babel">
    ReactDOM.render(
    <h1>Hello World</h1>,
    document.getElementById('app')
    );
</script>

//Functional Components
function WelcomeUser(props) {
	return <h1>Hi {props.userName}</h1>;
}

const element = <WelcomeUser userName="venu" />;

ReactDOM.render(element,document.getElementById('app') );

//TypeScript Functional Components
import React from 'react';
import styles from './Header.module.css';

const Header:React.FunctionComponent = () => (
  <div className={styles.Header}>
    Header Component
  </div>
);

export default Header;


//Function Component with state Management
import React, { useState } from 'react'
export const Counter: React.FunctionComponent<ICounterProps> =
    (props: IMyCounterProps) => {
								const [count, setCount] = useState(0) //React Hooks
								return (
										<p>You clicked Counter {count} times</p>
										<button type="submit" onClick={() => setCount(count + 1)}>Click												Counter</button>
										)
								}
interface ICounterProps {
// TODO
}

```



##### TypeScript Components

----

```typescript
//iCounterState.tsx
export interface ICounterState {
    count: number
 }
//iCounterProps.tsx
export interface ICounterProps {
    // TODO
}

//Couter .tsx
import React from 'react'
import { ICounterProps } from './iCounterProps'
import { ICounterState } from './iCounterState'
export default class Counter extends React.Component<ICounterProps ,ICounterState> {

constructor(props:ICounterProps) {
    super(props)
    this.state = {count: 0}
}

render() {
        return (
                <div>
                    <p>You clicked Counter {this.state.count} times</p>
                    <button type="submit" onClick={() => this.setState({ count: this.state.count + 1 })}>Click Counter</button>
                </div>
                )
        }
}
 
 
```

=======
#### DOM

---

- The DOM in HTML stands for Document Object Model. It is an in-memory representation of HTML and is tree-structured.
- The Document Object Model is the API for HTML and even XML documents such as SVG images.

- The DOM document consists of a hierarchical tree of nodes (https://developer.mozilla.org/en-US/docs/Web/API/Node), and the node interface allows access not just to the document but to each element
- DOM manipulation is the core of modern interactive web pages and can dynamically change the content of a web page

####  React Virtual DOM Under the Hood

---

> It’s crucial that the actual DOM tree-structured manipulation be as quick as possible. For example, say we have a product page, and we want to update the first item of our product’s list. Most JavaScript frameworks would update the entire list just to update one item, which may contain hundreds of items. Most modern web pages hold large DOM structures, and this behavior taxes the user too much, resulting in slower-loading HTML pages.
>
> The **virtual DOM (VDOM)** is a programming concept where an ideal, or virtual, representation of a UI is kept in memory and synced with the “real” DOM by a library such as **ReactDOM**. This process is called **reconciliation**. The React VDOM’s aim is to
> speed up this process.
>
> React determines what changes to make to the actual DOM based on the React element representation and do the changes in the background inside a virtual DOM .Then it commits only needed changes to the actual user’s DOM (browser). The
> reason behind this process is to speed up performance
>
> React holds a copy of the HTML DOM (that’s the virtual DOM). Once a change is needed, React first makes the change to the virtual DOM, and it then syncs the actual HTML DOM, avoiding the need to update the entire HTML DOM, which speeds up the process.
>
> For example, when we render a JSX element, every single virtual DOM object gets updated. This process of updating the entire virtual DOM instead of the actual HTML DOM is faster. In the **reconciliation** process, React needs to figure out which objects changed, and this process is called **diffing**. Then React updates only the objects in the real HTML DOM that need to be changed instead of the entire DOM tree.



```html
<html>
<head>
	<meta charSet="utf-8">
	<title>Hello world</title>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/react/17.0.0/umd/react.production.min.js"></script>
	<script src="https://unpkg.com/react-dom@17.0.0/umd/react-dom.production.min.js"></script>
	<script src="https://unpkg.com/@babel/standalone/babel.min.js"></script>
    </head>
    <body>
    <div id="app"></div>
        <script type="text/babel">
        ReactDOM.render(
        <h1>Hello World</h1>,
        document.getElementById('app')
        );
		</script>
        
    </body>
</html>
```

##### Why Should You Integrate TypeScript into Your React Project?

----

> You can write React code using JavaScript (JS) or TypeScript (TS).

- TypeScript is an OOP language; JavaScript is a scripting language.
-  TypeScript uses static typing following the ECMAScript specification.
-  TypeScript support modules



##### React Template Starter Project Options

----

- Most popular template for creating a React app is the Create-React-App (CRA) project (https://github.com/facebook/create-react-app).
  - It provides a boilerplate project, and you can be up and running quickly with many of the necessary tools and library that are standards when building a top-grade React application.
  - CRA has already made some decisions . For example, the build tool is a tool called Webpack over Rollup or Parcel. Task Runners is set up with NPM scripts over other tools such as Gulp. CSS, JS, and Jest are used as the defaults.
- **React Eco System**
  - Type checker: TypeScript
  - Preprocessors: Sass/SCSS
  -  State management: Redux Toolkit/Recoil
  - CSS framework: Material-UI / Bootstarp
  -  Components: Styled Components
  -  Router: React Router
  -  Unit testing: Jest and Enzym + Sinon
  -  E2E testing: Jest and Puppeteer
  -  Linter: ESLint and Prettier
  - Other useful libraries: Lodash, Moment, Classnames, Serve, reactsnap,
    React-Helmet, Analyzer Bundle
- Prerequisites
  - Install **Node** and **NPM**
  - Install Yarn/NPM 
    - npm install --global yarn



##### Create-React-App with TypeScript

---



```typescript
$ yarn create react-app my-app --template typescript
$ cd my-app
$ yarn start

//add the following types for TS so that Webpack knows how to handle .tsx file types and bundle them and so they can be included as static assets in our project.
$ yarn add -D typescript @types/node @types/react @types/react-dom @types/jest @typescript-eslint/scope-manager
```

##### React Project Folder Structure

---

- src/components
-  src/features
-  src/layout
-  src/pages
- src/redux

##### Generate Templates

----

You can generate your project templates using the generate-react-cli project in React. To install

```
npx generate-react-cli component Header
```



##### React components

React components enables by breaking down a complex UI into small, stand-alone pieces. In fact, the heart of React
is nothing more than a compilation of components working together in harmony. 

> Components let you split the UI into independent, reusable pieces, and think about each piece in isolation
>
> —React.org docs, https://reactjs.org/docs/components-and-props.html

##### Types of components.

---

- Functional components
- Class components
-  Factory components

##### Classification

---

- JavaScript (JS) functions and class components
- TypeScript (TS) functions and class components
-  Exotic components such as factory components
-  Complex TS factory components
- React.PureComponent versus React.Component



##### Functional Component

---

> Function components (also called functional stateless components) are nothing more than JavaScript functions

```javascript
<div id="app"></div>
<script type="text/babel">
    ReactDOM.render(
    <h1>Hello World</h1>,
    document.getElementById('app')
    );
</script>

//Functional Components
function WelcomeUser(props) {
	return <h1>Hi {props.userName}</h1>;
}

const element = <WelcomeUser userName="venu" />;

ReactDOM.render(element,document.getElementById('app') );

//TypeScript Functional Components
import React from 'react';
import styles from './Header.module.css';

const Header:React.FunctionComponent = () => (
  <div className={styles.Header}>
    Header Component
  </div>
);

export default Header;


//Function Component with state Management
import React, { useState } from 'react'
export const Counter: React.FunctionComponent<ICounterProps> =
    (props: IMyCounterProps) => {
								const [count, setCount] = useState(0) //React Hooks
								return (
										<p>You clicked Counter {count} times</p>
										<button type="submit" onClick={() => setCount(count + 1)}>Click												Counter</button>
										)
								}
interface ICounterProps {
// TODO
}

```



##### TypeScript Components

----

```typescript
//iCounterState.tsx
export interface ICounterState {
    count: number
 }
//iCounterProps.tsx
export interface ICounterProps {
    // TODO
}

//Couter .tsx
import React from 'react'
import { ICounterProps } from './iCounterProps'
import { ICounterState } from './iCounterState'
export default class Counter extends React.Component<ICounterProps ,ICounterState> {

constructor(props:ICounterProps) {
    super(props)
    this.state = {count: 0}
}

render() {
        return (
                <div>
                    <p>You clicked Counter {this.state.count} times</p>
                    <button type="submit" onClick={() => this.setState({ count: this.state.count + 1 })}>Click Counter</button>
                </div>
                )
        }
}
 
 
```

>>>>>>> 4eadd0dc788ab5c372c22e514d24e095d5ef9eff
