import React, { useState} from "react"
import { AddItemButton } from "../../styles"
import {NewItemForm} from '../newItemForm/newItemForm'


export const AddNewItem = (props:AddNewItemProps) => {
    const [showForm, setShowForm] = useState(false);
    const { onAdd, toggleButtonText, dark } = props;
    if (showForm) {
    // We show item creation form here
    return (
        <NewItemForm onAdd={text => {
        onAdd(text)
        setShowForm(false)
        }}
        />
        )
    }
    return (
    <AddItemButton dark={dark} onClick={() => setShowForm(true)}>
    {toggleButtonText}
    </AddItemButton>
    )
    }
    
    interface AddNewItemProps {
        onAdd(text: string): void
        toggleButtonText: string
        dark?: boolean
    }
    