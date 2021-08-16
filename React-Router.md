## Why Do We Need a Router?

Building an application on a single component is not ideal as the code and complexity will grow, and it can become a developer nightmare to maintain and test . What we really do during routing is take a single-page app in React and dynamically
switch out the different tree objects in the browser using the React virtual DOM. The changes happen faster than in a traditional HTML paradigm as only the changes are updated on the actual DOM.
During this “**reconciliation**,” React figures out which objects have changed with a diffing process. Then React updates only the objects in the “real” HTML DOM that need to be changed. This speeds up the process

## React Router

- How to install and configure React Router
- Adding the <Switch> component
- Adding the exact property
- Adding parameters to the routes



#### Installing and configuring React Router

---

```
npm install react-router-dom @types/react-router-dom
or 
yarn add react-router-dom @types/react-router-dom
```



#### match propoerty

----

React Router has a special prop called match, which is an object that contains all the data related to the route, and if we have parameters, we will be able to see them in the match object:



## Why Do We Need a CSS Framework?

A CSS framework (or CSS library) brings a more standardized practice to your development. Using a CSS framework, we can speed up our development effort versus using just plain old CSS (or other style sheets), as it allows us to use predefined elements. Yes, we could create all these custom components from scratch, style them, and test them on all devices and even legacy browsers, but most of the time it isn’t worth the effort. We are not looking here to reinvent the wheel. Instead, we can just use predefined elements

#### Choices

---

- Bootstrap: 143,000 stars
- Material-UI: 60,000 stars
- Bulma: 40,000 stars
- Semantic UI: 48.3,000 stars

The Material-UI framework (https://material-ui.com/) is based on Facebook’s React framework and integrates well with React. Being built by the Facebook team is a big deal because we want to ensure that our code won’t break when we upgrade our
React project to future React versions.

 The GitHub page of Material-UI is here:
https://github.com/mui-org/material-ui



#### How Can We Integrate Material-UI into Our ReactJS Project?

---



```
yarn add -D @material-ui/core @material-ui/icons
or
yarn add -D styled-components @types/styled-components
```

