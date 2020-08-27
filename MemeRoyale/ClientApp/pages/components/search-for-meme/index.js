import React, { useState } from 'react';
import { TextField, Button, Cutout, Divider } from 'react95';
import styles from './search-for-meme.module.css'
import Meme from '../meme';
const Logo = 'https://github.com/jbd95.png';

function SearchForMeme() {

  const [text, setText] = useState('');

  return (
    <Cutout className={styles.container}>
      <div className={styles.title}> Choose the next GIF to meme </div>
      <Divider/>
      <div className={styles.searchContainer}>
        <TextField
          className={styles.searchBar}
          value={text}
          placeholder='Search to find cool gifs...'
          onChange={(e) => setText(e.target.value)}
          fullWidth
        />
        <Button>
          Search
        </Button>
      </div>
      <div>
        <Meme src={Logo} width='200px' height='200px'/>
      </div>
    </Cutout>
  );
}

export default SearchForMeme;