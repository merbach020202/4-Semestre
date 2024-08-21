import Edit from "../../assets/Icons/botao-editar.png"
import Cancel from "../..//assets/Icons/cancelar.png"

import { Link, animateScroll as scroll } from "react-scroll";

import { Conteiner, ConteinerInputBox } from "../Conteiner/Style"
import { ButtonToDo, CheckBox, DisplayList, ImageInputBox, TextButton } from "./Style"
import Form from "../Form/Form"
import Input from "../Input/Input"
import Button from "../Button/Button"
import List from "../List/list"
import { useState } from "react"




export const InputBox = ({ }) => {

    const [task, setTask] = useState('');
    const [itemsList, setItemsList] = useState([]);

    function handleChangeInput(event) {
        const inputTask = event.target.value;

        setTask(inputTask);
    }

    function handleAddItemToList(event) {
        event.preventDefault();

        if (!task) {
            return;
        }

        setItemsList([...itemsList, task]);
        setTask('');
    }

    function handleRemoveItemFromList(event) {

    }

    function handleEditItemFromList(event) {

    }

    // return (
    //     <ConteinerInputBox>

    //         <CheckBox
    //             color="red"
    //             onClick={null}
    //         />

    //         <ImageInputBox>
    //             <img src={Edit} height='30px' width='30px' onClick={null} />
    //             <img src={Cancel} height='30px' width='30px' onClick={null} />
    //         </ImageInputBox>

    //     </ConteinerInputBox>
    // )



    return (
        <Conteiner>

            <ConteinerInputBox>


                <Form onSubmit={handleAddItemToList}>
                    <Input
                        type="text"
                        placeholder="Nova Tarefa"
                        onChange={handleChangeInput}
                        value={task}
                    />

                    <Button type="submit">Adicionar</Button>

                    <DisplayList>
                        <List itemsList={itemsList} />
                    </DisplayList>
                </Form>

                <Link
                    activeClass="active"
                    to="section1"
                    spy={true}
                    smooth={true}
                    offset={-70}
                    duration={500}
                />


                <ImageInputBox>
                    <img src={Edit} height='30px' width='30px' onClick={handleRemoveItemFromList} />
                    <img src={Cancel} height='30px' width='30px' onClick={handleEditItemFromList} />
                </ImageInputBox>

            </ConteinerInputBox>

            <ButtonToDo>
                <TextButton>Nova Tarefa</TextButton>
            </ButtonToDo>

        </Conteiner>
    );
}


