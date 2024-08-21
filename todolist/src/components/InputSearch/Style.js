import styled from "styled-components";

export const InputSearch = styled.input`
    height: 45px;
    width: 310px;

    border: 1px solid white;
    border-radius: 15px;
    background-color: transparent;

    position: static;
    padding: 0px 0px 0px 10px;

    &::placeholder {
    color: ${props => props.color || '#FCFCFC'};
    opacity: 1;
  }
`

