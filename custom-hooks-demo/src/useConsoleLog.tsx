import { useEffect } from "react";
export function useConsoleLog(message:string){

    useEffect(()=>{

        console.log(message);
    });

}