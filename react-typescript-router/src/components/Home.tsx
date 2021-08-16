import {Link, Route} from 'react-router-dom'
import {FC, ReactNode} from 'react'
import { Customers } from './Customers'
import Projects from './Projects'
type Props = {
    children: ReactNode,
    match:any
    }
const Home:FC<Props> = ({children,match}) => (
    <div className="Home">
    <h1>Home</h1>
<Link to="home/customers">Customers</Link>
<Link to="home/projects">Projects</Link>
<Route exact path={`${match.path}/customers`} component={Customers}></Route>
<Route exact path={`${match.path}/projects`} component={Projects}></Route>

    </div>
    )
    export default Home