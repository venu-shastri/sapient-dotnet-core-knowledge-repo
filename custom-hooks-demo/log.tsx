import { useEffect } from "react";

export function useLog(message:string){
    
    useEffect(()=>{

        console.log(message);
    });
}