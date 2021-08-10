import React from 'react'
import { ICounterProps } from './iCounterProps'
import { ICounterState } from './iCounterState'
export default class Counter extends React.Component<ICounterProps ,ICounterState> {

constructor(props:ICounterProps) {
    super(props);
    this.state = {count: 0};
    this.handleClick=this.handleClick.bind(this);
}

handleClick(e: React.MouseEvent) {
    this.setState(prevState => {
    const newState = prevState.count+1;
    return ({...prevState,count: newState });
    }
    )
}
render() {
        return (
                <div>
                    <p>You clicked Counter {this.state.count} times</p>
                    <button type="submit" onClick={this.handleClick}>Click Counter</button>
                </div>
                )
        }
}


    