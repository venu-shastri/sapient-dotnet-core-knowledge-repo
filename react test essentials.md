### React Testing 

---

When it comes to testing your React app, there are three areas of testing to consider.
• Unit testing: Testing the smallest piece of code that can be isolated.
• Integration testing: Combining individual modules and testing the together
• E2E testing: Simulating a real end user’s experience



>When it comes to unit testing, there are many libraries that can be used with React such as **Jest, Enzyme/react-testing-library, Sinon, Mocha, Chai, Ava, and Tape.**

### How to test React Components

----

- Testing with React Testing Library

  - @testing-library/react

- Testing components directly

  - Every Component is function  object 

- Testing with Test Utilities

  - react-dom/test-utils'

  - act 

    - Provides a more realistic environment for rendering and updating components.

    - ```javascript
      act(() => {
      ReactDOM.render(<SomeComponent propContent="Some Value" propValid={true} />,
      container);
      });
      
      const button = container.querySelector(‘search’);
      act(() => {
      button.dispatchEvent(new MouseEvent('click', {bubbles: true}));
      });
      ```

      

- Testing with Test Renderer

  - Render to objects
  - Test rendering logic
  - More realistic environment
  - Traversal API
  - **yarn add react-test-renderer** **@types/react-test-renderer**

```javascript
const root = TestRenderer.create( <SomeComponent propOne="Some Content" propTrue={true} />).root;
root.findAllByType(“div”);
root.findByProps({“data-testid”: “visa-card”});
root.findAll((i) => i.children.length > 0);
```



### What Is the Jest Library?

---

>  Jest (https://github.com/facebook/jest) is a Facebook JavaScript unit testing  framework. It was built to be used with any JavaScript project. 

>Jest is a **test runner**, **assertion library**, and **mocking library**. It also provides a **snapshot** if needed

##### Benefits:

- Developer ready: It is a comprehensive JavaScript testing solution. It works out of the box for most JavaScript projects
- Instant feedback: It has a fast, interactive watch mode that only runs test files related to changed files.
- Snapshot testing: It captures snapshots of large objects to simplify testing and to analyze how they change over time.

 **If you use Create React App, [Jest is already included out of the box](https://facebook.github.io/create-react-app/docs/running-tests) with useful defaults.**

### What Is Enzyme?

----

Enzyme (https://github.com/enzymejs/enzyme) is a JavaScript testing utility built for React  by Airbnb. Enzyme  makes it easier to test your React components’ output You can also manipulate, traverse, and in some ways simulate the runtime given the output. Enzyme’s API is meant to be intuitive and flexible by mimicking jQuery’s API for DOM manipulation and traversal.

 Enzyme  provides us with mechanism to test the implementation details of a React component. It can provide us with access to the state, props and children components of a React component while writing test.

### What is react-testing-library

---

- React Testing Library is a light-weight testing library.
- React Testing Library uses the render logic to run our assertions
- Library doesn’t provide us the access to the component’s properties such as it’s state and props
- The assertions are made from the DOM elements which can be accessed by the utility provided by React Testing Library
- [testing-library/react-testing-library: ](https://github.com/testing-library/react-testing-library)

#### Render Function

---

- Renders a React Component
- Returns Container and Query Function



### Enzyme / react-testing-library

---

[Enzyme vs. react-testing-library: A mindset shift - LogRocket Blog](https://blog.logrocket.com/enzyme-vs-react-testing-library-a-mindset-shift/)



###  Unit tests should adhere to the FIRST principle

----

- Fast
- Isolated
- Repeatable
- Self-verifying
- Timely

### Essential Jest functions

---

##### describe

You use the describe function to group together a series of tests. This group of tests is known as a test suite. The describe function takes two parameters, a string and a callback function, in the following format:

**describe(string describing the test suite, callback);**

You can have as many describe functions as you want. The number of describe functions depends on how you want to organize your tests into suites. To organize your tests, you also can nest as many describe functions as you want.

**it**
You use the  it function when you want to create a specific test, which usually goes inside a describe function. Like the describe function, the it function takes two parameters— a string and a callback function—using the following format:

**it(string describing the test, callback);**

You create a test inside an it function by putting an assertion inside the callback function. You create an assertion by using the expect function

**expect**
The expect function comes into play in the code that confirms that the test works. These lines of code are also known as the assertion because you’re asserting something as being true. In Jasmine, the assertion is in two parts: the **expect function** and the **matcher**. The expect function is where you pass in the value; for example, a Boolean value true. The matcher function is where you put the expected value. Matcher function examples include **toBe(), toContain(), toThrow(), toEqual(), toBeTruthy(),**
**toBeNull()**



```javascript
describe('testsuite', () => {
    it('First Jest test', () => {
    	expect(true).toBe(true);
    });
});



```

##### Fixtures

Every unit test has three parts: arrange, act, and assert . The arrange part of unit tests can be repetitive as multiple test cases often require the same setup. Jest provides **fixtures** to help reduce the amount of repetition .

Types Of Fixtures





- **beforeEach**() – runs before each spec in describe
-  **afterEach**() – runs after each spec in describe

The fixtures execute before and after a spec or a group of specs as scoped with their describe block
