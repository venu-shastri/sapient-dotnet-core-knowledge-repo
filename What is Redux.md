# What is Redux?

There are two kinds of state in an application:

- **Local** **state**: For example, to handle input field data
- **Global** **state**: For example, to store the currently logged-in user

Previously in this book, we handled local state by using a State Hook, and more complex state (often global state) using a Reducer Hook.

Redux is a solution that can be used to handle all kinds of state in React applications. It provides a single state tree object, which contains all application state. This is similar to what we did with the Reducer Hook in our blog application. Traditionally, Redux was also often used to store local state, which makes the state tree very complex.

Redux essentially consists of five elements:

- **Store**: Contains state, which is an object that describes the full state of our application—{ todos: [], filter: 'all' }
- **Actions**: Objects that describe a state modification—{ type: 'FILTER_TODOS', filter: 'completed' }
- **Action creators**: Functions that create action objects—(filter) => ({ type: 'FILTER_TODOS', filter })
- **Reducers**: Functions that take the current state value and an action object, and return a new state—(state, action) => { ... }
- **Connectors**: Higher-order components that connect an existing component to Redux, by injecting the Redux state and action creators as props—connect(mapStateToProps, mapDispatchToProps)(Component)

In the Redux life cycle, the **Store** contains state, which defines the UI. The UI is connected to the Redux store, via **Connectors**. User interactions with the UI then trigger **Actions**, which are sent to the **Reducer**. The **Reducer** then updates the state in the **Store**.

We can see a visualization of the Redux life cycle in the following diagram:

![img](file:///C:/Users/user/AppData/Local/Temp/mryv4o40.wrp/OEBPS/Images/56b43307-68c8-4181-9f8a-1a45e4e65da6.png)

Visualization of the Redux life cycle

As you can see, we have already learned about three of these components: the store (state tree), actions, and reducers. Redux is like a more advanced version of the Reducer Hook. The difference is that with Redux, we always dispatch state to a single reducer, therefore changing a single state. There should not be more than one instance of Redux. Through this restriction, we can be sure that our whole application state is contained in a single object, which allows us to reconstruct the whole application state, just from the Redux store.

As a result of having a single store containing all state, we can easily debug faulty states by saving the Redux store in a crash report, or we can automatically replay certain actions during debugging so that we do not need to manually enter text and click on buttons, over and over again. Additionally, Redux offers middleware that simplifies how we deal with asynchronous requests, such as fetching data from a server. 



# The three principles of Redux

The Redux API is very small, and actually only consists of a handful of functions. What makes Redux so powerful is a certain set of rules that are applied to your code when using the library. These rules allow for the writing of scalable applications that are easy to extend, test, and debug.

Redux is based on three fundamental principles:

- Single source of truth
- Read-only state
- State changes are processed with pure functions

# Installing Redux

First of all, we have to install Redux, React Redux, and Redux Thunk. Let us look at what each one does individually:

- Redux itself just deals with JavaScript objects, so it provides the store, deals with actions and action creators, and handles reducers.
- React Redux provides connectors in order to connect Redux to our React components.
- Redux Thunk is a middleware that allows us to deal with asynchronous requests in Redux.

Using **Redux** in combination with **React** offloads global state management to **Redux**, while **React** deals with rendering the application and local state:



![img](file:///C:/Users/user/AppData/Local/Temp/mryv4o40.wrp/OEBPS/Images/57db1dda-569a-49f4-848a-935ea4c4f55c.png)

Illustration of how React and Redux work together

To install Redux and React Redux, we are going to use npm. Execute the following command:

```
> npm install --save redux react-redux redux-thunk
```

Now that all of the required libraries are installed, we can start setting up our Redux store.

# Using Redux with Hooks

##### Using the store Hook

---

React Redux also provides a useStore Hook, which returns a reference to the Redux store itself. This is the same store object that was passed to the Provider component. Its API looks like this:

```
const store = useStore()
```

It is best practice to avoid using the Store Hook directly. It usually makes more sense to use Dispatch or Selector Hooks instead. However, there are special use cases, such as replacing reducers, where using this Hook may be required.



##### Using the useDispatch

----



The useDispatch Hook returns a reference to the dispatch function that is provided by the Redux store. It can be used to dispatch actions that are returned from action creators. Its API looks as follows:

```
const dispatch = useDispatch()
```

We are now going to use the Dispatch Hook to replace the existing container components with Hooks.

> You do not need to migrate your whole Redux application at once in order to use Hooks. It is possible to selectively refactor certain components—meaning that they will use Hooks—while still using connect() for other components.

##### Using the Selector Hook

----

Another very important Hook that is provided by Redux is the Selector Hook. It allows us to get data from the Redux store state, by defining a selector function. The API for this Hook is as follows:

```
const result = useSelector(selectorFn, equalityFn)
```

selectorFn is a function that works similarly to the mapStateToProps function. It will get the full state object as its only argument. The selector function gets executed whenever the component renders, and whenever an action is dispatched (and the state is different than the previous state).

It is important to note that returning an object with multiple parts of the state from one Selector Hook will force a re-render every time an action is dispatched. If multiple values from the store need to be requested, we can do the following:

- Use multiple Selector Hooks, each one returning a single field from the state object
- Use reselect, or a similar library, to create a memoized selector (we are going to cover this in the next section)
- Use the shallowEqual function from react-redux as equalityFn

# Trade-offs of Redux

To wrap up, let us summarize the pros and cons of using Redux in a web application. First, let us start with the positives:

- Provides a certain project structure that allows us to easily extend and modify code later on
- Fewer possibilities for errors in our code
- Better performance than using React Context for state
- Makes the App component much simpler (offloads state management and action creators to Redux)

Redux is a perfect fit for larger projects that deal with complex state changes, and state that is used across many components.

However, there are also downsides to using Redux:

- Writing boilerplate code required
- Project structure becomes more complicated
- Redux requires a wrapper component (Provider) to connect the app to the store

As a result, Redux should not be used for simple projects. In these cases, a Reducer Hook might be enough. With a Reducer Hook, there is no need for wrapper components in order to connect our app to the state store. Furthermore, if we use multiple Reducer Hooks, it is slightly more performant to send actions to a specific reducer, instead of a global app reducer. However, the downside lies in having to deal with multiple dispatch functions, and keeping the various states synchronized. We also cannot use middleware, including support for asynchronous actions, with a Reducer Hook. If state changes are complex but only local to a certain component, it might make sense to use a Reducer Hook, but if the state is used throughout multiple components, or it is relevant for the whole app, we should definitely store it in Redux.

You might not need Redux if your component does not do the following:

- Use the network
- Save or load state
- Share state with other non-child components

In that case, it makes sense to use a State or Reducer Hook, instead of Redux.