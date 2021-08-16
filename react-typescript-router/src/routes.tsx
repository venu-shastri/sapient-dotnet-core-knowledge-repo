// Dependencies
import { Route,Switch } from 'react-router-dom'
// Components
import App from './App'
import Home from './components/Home'
import About from './components/About'
import Contact from './components/Contact'
import Error404 from './components/Error404'
import Contacts from './components/Contacts'


const AppRoutes = () => (
<App>
 <Switch>
<Route path="/" component={Home}  ></Route>
<Route path="/about" component={About} exact />
<Route path="/contact" component={Contact} exact />
<Route path="/contacts" component={Contacts} exact />
<Route path="/contacts/:contactId" component={Contacts} exact /> 

{/* <Route component={Error404}></Route> */}

 </Switch>
</App>
)
export default AppRoutes