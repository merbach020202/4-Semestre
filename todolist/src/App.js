import './App.css';
import { ConteinerHeader } from './components/Conteiner/Style';
import { InputSearch } from './components/InputSearch/Style';

import Search from "../src/assets/Icons/Search.png"


function App() {
  return (
    <div className="App">
      <header className="App-header">

        <ConteinerHeader>
          <h1>Terça-Feira, 24 de Julho</h1>

          <InputSearch
            placeholder='Procurar tarefa'
            color='#FCFCFC'
          />
          <img src={Search}/>

          
        </ConteinerHeader>

      </header>
    </div>
  );
}

export default App;

