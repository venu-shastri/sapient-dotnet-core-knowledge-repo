import React from 'react'

// export function Clock(props){
//     let date=new Date();
//     setInterval(() => {
//         date=new Date();
//         console.log(date.toLocaleTimeString());
//     }, 1000);
//     return(
//         <div>
//         <h1>Spaient Clock</h1>
//         <h2>It is {date.toLocaleTimeString()}.</h2>
//         </div>

//     );
// }
export class Clock extends React.Component{
 
    constructor(props){
            super(props);
            this.state={currentTime:new Date().toLocaleTimeString(),key:"v1",key2:"v2"};
    }
    //Lifecycle Hooks
    componentDidMount(){
       this.timerId= setInterval(()=>{

            this.setState({...this.state , currentTime:new Date().toLocaleTimeString()});
        },1000);
    }
    //LifeCycle Hooks
    componentWillUnmount(){
        clearInterval(this.timerId);
    }
    render(){

        return (
            <div>
         <h1>Spaient Clock</h1>
         <h2>It is {this.state.currentTime}.</h2>
         </div>

        );
    }
}