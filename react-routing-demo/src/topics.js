import React,{Component} from 'react'
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import { TopicComponent } from './topic';
export class TopicsComponent extends Component{

    constructor(props){
        super(props);
    }
    render(){
        return(

            <div>
            <h2>Topics</h2>
            <ul>
              <li>
                <Link to={`${this.props.match.url}/rendering`}>Rendering with React</Link>
              </li>
              <li>
                <Link to={`${this.props.match.url}/components`}>Components</Link>
              </li>
              <li>
                <Link to={`${this.props.match.url}/props-v-state`}>Props v. State</Link>
              </li>
            </ul>
      
            <Route path={`${this.props.match.path}/:topicId`} component={TopicComponent} />
            <Route
              exact
              path={this.props.match.path}
              render={() => <h3>Please select a topic.</h3>}
            />
          </div>
        );
    }

}