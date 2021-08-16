import React,{Component} from 'react'
export class TopicComponent extends Component{

    render(){

        return (

            <div>
            <h3>{this.props.match.params.topicId}</h3>
          </div>
        );
    }
}