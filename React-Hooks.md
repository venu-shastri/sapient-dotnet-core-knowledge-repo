#### React Hooks

-----



1. What are React's three fundamental principles? 
   - **Declarative**: Instead of telling React how to do things, we tell it what we want. As a result, we can easily design our applications and React will efficiently update and render just the right components when data changes.
   - **Component-based**: React encapsulates components that manage their own state and views, then allows us to compose them to create complex user interfaces.
   - **Learn once, write anywhere:** React does not make assumptions about your technology stack and tries to ensure you can develop without rewriting existing code as much as possible.
2. What are the two types of components in React? 
   - **Function components**: JavaScript functions that take the props as an argument and return the user interface (usually via JSX)
   - **Class components**: JavaScript classes that provide a render method, which returns the user interface (usually via JSX)
3. What are the problems with class components in React? 
   - JavaScript classes are hard to understand for developers: The this context can be confusing, and we sometimes have to write code in multiple places at once
   - They are also hard to understand for machines: It is hard to tell which methods will be called and, as such, performance optimizations are not really possible

- - They are not declarative and thus go against React's fundamental principles: To use React features, we have to write code that tells React what to do, not how to do it

1. What is the problem of using higher-order components in React? 

   - Using higher-order components introduces components to our view tree that do not actually matter in terms of view structure. Having many higher-order components causes the so-called **wrapper hell**.

2. Which tool can we use to set up a React project, and what is the command that we need to run to use it? 

   - We can use create-react-app. To create a new project, we have to run npx create-react-app <app-name> or yarn create react-app <app-name>.

3. What do we need to do if we get the following error with class components: 

   TypeError: undefined is not an object (evaluating 'this.setState')

   ?

   - We forgot to re-bind the this context of the method in the constructor of our class. As a result, this is not pointing to the class but, instead, to the context of the input field.

4. How do we access and set React state using Hooks? 

   - We make use of the useState() Hook as follows: const [ name, setName ] = useState('')

5. What are the advantages of using function components with Hooks, in comparison to class components? 

   - Function components with Hooks do not suffer from the same problems as classes. They are declarative and thus fit React's fundamental principles better. Hooks also make our code more concise and easier to understand.

6. Do we need to replace all class components with function components using Hooks when updating React? 

   - No, we do not need to replace all class components. Function components with Hooks can work side-by-side with existing class components and are 100% backward-compatible. We can simply write new components using Hooks or upgrade existing components at our own pace.

7. What are the three basic hooks provided by React? 

- The useState, useEffect, and useContext Hooks are the basic Hooks provided by React and used very frequently in projects. However, React also provides some more advanced Hooks out of the box



# Hooks provided by React

##### Basic Hooks

----

- useState
- useEffect
- useContext
- useRef
- usReducer
- useCallback
- useMemo

# useState

We have already used this Hook. It returns a stateful value (state) and a setter function (setState) in order to update the value.

The useState Hook is used to deal with state in React. We can use it as follows:

```
import { useState } from 'react'

const [ state, setState ] = useState(initialState)
```

**The useState Hook replaces this.state and this.setState().**

# useEffect

This Hook works similarly to adding a function on componentDidMount and componentDidUpdate. Furthermore, the Effect Hook allows for returning a cleanup function from it, which works similarly to adding a function to componentWillUnmount.

The useEffect Hook is used to deal with effectful code, such as timers, subscriptions, requests, and so on. We can use it as follows:

```
import { useEffect } from 'react'

useEffect(didUpdate)
```

The useEffect Hook replaces the componentDidMount, componentDidUpdate, and componentWillUnmount methods.



# useContext

This Hook accepts a context object and returns the current context value.

The useContext Hook is used to deal with context in React. We can use it as follows:

```
import { useContext } from 'react'

const value = useContext(MyContext)
```

The useContext Hook replaces context consumers.

# useRef

This Hook returns a mutable ref object, where the .current property is initialized to the passed argument (initialValue). We can use it as follows:

```
import { useRef } from 'react'

const refContainer = useRef(initialValue)
```

The useRef Hook is used to deal with references to elements and components in React. We can set a reference by passing the ref prop to an element or a component, as follows: <ComponentName ref={refContainer} />

# useReducer

This Hook is an alternative to useState, and works similarly to the Redux library. We can use it as follows:

```
import { useReducer } from 'react'

const [ state, dispatch ] = useReducer(reducer, initialArg, init)
```

The useReducer Hook is used to deal with complex state logic.

# useMemo

Memoization is an optimization technique where the result of a function call is cached, and is then returned when the same input occurs again. The useMemo Hook allows us to compute a value and memoize it. We can use it as follows:

```
import { useMemo } from 'react'

const memoizedValue = useMemo(() => computeExpensiveValue(a, b), [a, b])
```

The useMemo Hook is useful for optimization when we want to avoid re-executing expensive operations.

# useCallback

This Hook allows us to pass an inline callback function, and an array of dependencies, and will return a memoized version of the callback function. We can use it as follows:

```
import { useCallback } from 'react'

const memoizedCallback = useCallback(
    () => {
        doSomething(a, b)
    },
    [a, b]
)
```

The useCallback Hook is useful when passing callbacks to optimized child components. 

# useState

1. First, we remove all code from the src/App.js file.
2. Next, in src/App.js, we import React, and the **useState** Hook:

```
    import React, { useState } from 'react'
```

1. We start with the function definition. In our case, we do not pass any arguments, because our component does not have any props:

```
    function EchoComponent () {
```

The next step would be to get the name variable from the component state. However, we cannot use this.state in function components. We have already learned that Hooks are just JavaScript functions, but what does that really mean? It means that we can simply use Hooks from function components, just like any other JavaScript function!

To use state via Hooks, we call **useState**() with our initial state as the argument. This function returns an array with two elements:

- - The current state
  - A setter function to set the state

1. We can use **destructuring** to store these two elements in separate variables, as follows:

```
            const [ name, setName ] = useState('')
```

The previous code is equivalent to the following:

```
            const nameHook = useState('')
            const name = nameHook[0]
            const setName = nameHook[1]
```

1. Now, we define the input handler function, where we make use of the setName setter function:

```
            function handleChange (evt) {
                setName(evt.target.value)
            }
```

As we are not dealing with classes now, there is no need to rebind this anymore!

1. Finally, we render our user interface by returning it from the function. Then, we export the function component:

```
    return (
        <div>
            <h1>Echo: {name}</h1>
            <input type="text" value={name} onChange={handleChange} />
        </div>
    )
}

export default MyName
```

And that's it—we have successfully used Hooks for the first time! As you can see, the **useState** Hook is a drop-in replacement for **this.state** and **this.setState.**

Let's run our app by executing npm start, and opening http://localhost:3000 in our browser:

# Comparing the solutions

The class component makes use of the constructor method in order to define state, and needs to rebind this in order to pass the handler method to the input field. The full class component code looks as follows:

```
import React from 'react'

class Echo extends React.Component {
    constructor (props) {
        super(props)
        this.state = { name: '' }

        this.handleChange = this.handleChange.bind(this)
    }

    handleChange (evt) {
        this.setState({ name: evt.target.value })
    }

    render () {
        const { name } = this.state
        return (
            <div>
                <h1>Echo: {name}</h1>
                <input type="text" value={name} onChange={this.handleChange} />
            </div>
        )
    }
}

export default Echo
```

As we can see, the class component needs a lot of boilerplate code to initialize the state object and handler functions.

Now, let's take a look at the function component.

The function component makes use of the **useState** Hook instead, so we do not need to deal with this or a constructor method. The full function component code looks as follows:

```
import React, { useState } from 'react'

function Echo () {
    const [ name, setName ] = useState('')

    function handleChange (evt) {
        setName(evt.target.value)
    }

    
    return (
        <div>
            <h1>Echo: {name}</h1>
            <input type="text" value={name} onChange={handleChange} />
        </div>
    )
}

export default Echo
```

As we can see, Hooks make our code much more concise and easier to reason about. We do not need to worry about how things work internally anymore; we can simply use state, by accessing the **useState** function!



# Using Effect Hooks

If you have worked with React before, you have probably used the componentDidMount and componentDidUpdate life cycle methods. For example, we can set the document title to a given prop as follows, using a React class component. In the following code section, the life cycle method is highlighted in bold:

```
import React from 'react'

class App extends React.Component {
    componentDidMount () {
        const { title } = this.props
        document.title = title
    }

    render () {
        return (
            <div>Test App</div>
        )
    }
}
```

This works fine. However, when the title prop updates, the change does not get reflected in the title of our web page. To solve this problem, we need to define the componentDidUpdate life cycle method (new code in bold), as follows:

```
import React from 'react'

class App extends React.Component {
    componentDidMount () {
        const { title } = this.props
        document.title = title
    }

    componentDidUpdate (prevProps) {
        const { title } = this.props
        if (title !== prevProps.title) {
            document.title = title
        }
    }

    render () {
        return (
            <div>Test App</div>
        )
    }
}
```

You might have noticed that we are writing almost the same code twice; therefore, we could create a new method to deal with updates to title, and then call it from both life cycle methods. In the following code section, the updated code is highlighted in bold:

```
import React from 'react'

class App extends React.Component {
    updateTitle () {
        const { title } = this.props
        document.title = title
    }

    componentDidMount () {
        this.updateTitle()
    }

    componentDidUpdate (prevProps) {
        if (this.props.title !== prevProps.title) {
            this.updateTitle()
        }
    }

    render () {
        return (
            <div>Test App</div>
        )
    }
}
```

However, we still need to call this.updateTitle() twice. When we update the code later on, and, for example, pass an argument to this.updateTitle(), we always need to remember to pass it in both calls to the method. If we forget to update one of the life cycle methods, we might introduce bugs. Furthermore, we need to add an if condition to componentDidUpdate, in order to avoid calling this.updateTitle() when the title prop did not change

In the world of Hooks, the componentDidMount and componentDidUpdate life cycle methods are combined in the useEffect Hook, which—when not specifying a dependency array—triggers whenever any props in the component change.

So, instead of using a class component, we can now define a function component with an Effect Hook, which does the same thing as before. The function passed to the Effect Hook is called "effect function":

```
import React, { useEffect } from 'react'

function App ({ title }) {
    useEffect(() => {
        document.title = title
    })

    return (
        <div>Test App</div>
    )
}
```

And that's all we need to do! The Hook that we have defined will call our effect function every time any props change.



##### Trigger effect only when certain props change

If we want to make sure that our effect function only gets called when the title prop changes, for example, for performance reasons, we can specify which values should trigger the changes, as a second argument to the useEffect Hook:

```
    useEffect(() => {
        document.title = title
    }, [title])
```

And this is not just restricted to props, we can use any value here, even values from other Hooks, such as a State Hook or a Reducer Hook:

```
    const [ title, setTitle ] = useState('')
    useEffect(() => {
        document.title = title
    }, [title])
```

As we can see, using an Effect Hook is much more straightforward than using life cycle methods when dealing with changing values.

##### Trigger effect only on mount

If we want to replicate the behavior of only adding a componentDidMount life cycle method, without triggering when the props change, we can do this by passing an empty array as the second argument to the useEffect Hook:

```
    useEffect(() => {
        document.title = title
    }, [])
```

Passing an empty array means that our effect function will only trigger once when the component mounts, and it will not trigger when props change. However, instead of thinking about the mounting of components, with Hooks, we should think about the dependencies of effects. In this case, the effect does not have any dependencies, which means it will only trigger once. If an effect has dependencies specified, it will trigger again when any of the dependencies change.



##### Cleaning up effects

Sometimes effects need to be cleaned up when the component unmounts. To do so, we can return a function from the effect function of the Effect Hook. This returned function works similarly to the componentWillUnmount life cycle method:

```
    useEffect(() => {
        const updateInterval = setInterval(() => console.log('fetching update'), updateTime)

        return () => clearInterval(updateInterval)
    }, [updateTime])
```

The code marked in bold above is called the cleanup function. The cleanup function will be called when the component unmounts and before running the effect again. This avoids bugs when, for example, the updateTime prop changes. In that case, the previous effect will be cleaned up and a new interval with the updated updateTime value will be defined.





