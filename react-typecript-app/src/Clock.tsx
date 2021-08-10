import React from "react";
import { IClockProps } from "./IClockProps";
import { IClockState } from "./IClockState";
export class Clock extends React.Component<IClockProps,IClockState>{

    timerId:any=undefined;
    constructor(props:IClockProps){
    
        super(props);
        this.state={currentTime:new Date().toLocaleTimeString()}
    }

    //life Cycle Hook
    render(){
            return(
                <div>
         <h1>Spaient Clock</h1>
         <h2>It is {this.state.currentTime}.</h2>
         </div>
            );
    }
    componentDidMount(){
            this.timerId= setInterval(()=>{

                this.setState({...this.state,currentTime:new Date().toLocaleTimeString()});
            },1000);
    }
    componentWillUnmount(){
            clearInterval(this.timerId);
    }
}