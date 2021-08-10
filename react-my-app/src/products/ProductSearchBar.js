import React from "react";

export function ProductSearchBar(props){

    let searchKey=undefined;
   function onFormSubmit(e){

    props.searchKeyChanged(searchKey);
    }
    function onInputTextChange(e){
           searchKey= e.target.value;
    }
    return(
        <form onSubmit={onFormSubmit}>
        <input type="text" placeholder="Search..." onChange={onInputTextChange} />
        <input type="submit" value="Seacrh"></input>
      </form>
    );
}
export class ProductSearchBarClass extends React.Component{

    searchKey=undefined;
    onFormSubmit(e){

        this.props.searchKeyChanged(this.searchKey);
    }
    onInputTextChange(e){

        this.searchKey=e.target.value;
    }
    render(){
    return(
        <form onSubmit={this.onFormSubmit}>
        <input type="text" placeholder="Search..." onChange={this.onInputTextChange} />
        <input type="submit" value="Seacrh"></input>
      </form>
    );
    }

}