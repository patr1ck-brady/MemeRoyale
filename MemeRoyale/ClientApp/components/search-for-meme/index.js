import React, { useState } from 'react';
import clsx from 'clsx';
import { TextField, Button, Cutout, Divider, Window, WindowHeader, Hourglass } from 'react95';
import styles from './search-for-meme.module.css'
import Meme from '../meme';
import { loadGetInitialProps } from 'next/dist/next-server/lib/utils';
const Logo = 'https://github.com/jbd95.png';

function SearchForMeme() {

  const [text, setText] = useState('');
  const [loading, setLoading] = useState(false);
  const [selected, setSelected] = useState('');

  function handleSelect(src) {
    const selectedVal = selected;
    if(selectedVal === src) {
      setSelected('');
      return;
    }
    setSelected(src);
  }
  
  return (
    <Window className={styles.container}>
      <WindowHeader> Choose the next gif to meme </WindowHeader>
      <Divider/>
      <div className={styles.searchContainer}>
        <TextField
          className={styles.searchBar}
          value={text}
          placeholder='Search to find cool gifs...'
          onChange={(e) => setText(e.target.value)}
          fullWidth
        />
      </div>
      <div className={clsx(styles.gifContainer, { [styles.gifContainerLoading] : loading })}>
        {loading ?
          <Hourglass size={100}/>
        :
          <div className={styles.gifContainer}>
            <Meme src={'https://github.com/patr1ck-brady.png'} width='200px' height='200px' onClick={handleSelect} selected={selected === 'https://github.com/patr1ck-brady.png'}/>
            <Meme src={'https://github.com/adarsh9pai.png'} width='200px' height='200px' onClick={handleSelect} selected={selected === 'https://github.com/adarsh9pai.png'}/>
            <Meme src={'https://github.com/jbd95.png'} width='200px' height='200px' onClick={handleSelect} selected={selected === 'https://github.com/jbd95.png'}/>
            <Meme src={'https://github.com/AlejandroMartinez87.png'} width='200px' height='200px' onClick={handleSelect} selected={selected === 'https://github.com/AlejandroMartinez87.png'}/>
          </div>
        }
        
      </div>
    </Window>
  );
}

export default SearchForMeme;