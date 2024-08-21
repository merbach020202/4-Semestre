import './App.css';
import { ConteinerHeader, ConteinerInput, ConteinerInputBox, ConteinerInputSearch } from './components/Conteiner/Style';
import { InputSearch } from './components/InputSearch/Style';

import Search from "../src/assets/Icons/Search.png"
import { InputBox } from './components/InputBox/InputBox';

function App() {
  return (
    <div className="App">
      <header className="App-header">

        <ConteinerHeader>
          <h1>Terça-Feira, 24 de Julho</h1>

          <ConteinerInputSearch>
            <InputSearch
              placeholder='Procurar tarefa'
              color='#FCFCFC'
            />

            <img src={Search} height='30px' width='30px' />
          </ConteinerInputSearch>

            <InputBox/>

        </ConteinerHeader>

      </header>
    </div>
  );
}

export default App;



// <ConteinerHeader>
//   <h1>Terça-Feira, 24 de Julho</h1>

//     <InputSearch
//       placeholder='Procurar tarefa'
//       color='#FCFCFC'
//       img={Search}
//     />

//     <IconSearch imageRendering={Search}/>

//   {/* <img src={Search}/> */}


// </ConteinerHeader>

