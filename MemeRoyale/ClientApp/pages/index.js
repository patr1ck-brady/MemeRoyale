import Head from 'next/head'
import styles from '../styles/Home.module.css'
import SearchForMeme from '../components/search-for-meme'
import { ThemeProvider } from 'styled-components';
import original from 'react95/dist/themes/original';
import { Window } from 'react95';

export default function Home() {
  return (
    <div className={styles.container}>
      <ThemeProvider theme={original}>
        <Window>
          <SearchForMeme/>
        </Window>
      </ThemeProvider>
    </div>
  )
}
