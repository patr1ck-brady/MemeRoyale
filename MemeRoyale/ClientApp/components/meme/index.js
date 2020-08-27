import React from 'react';
import clsx from 'clsx';
import { Cutout } from "react95";
import styles from './meme.module.css';

function Meme(props) {
    return (
			<Cutout className={clsx(styles.container, { [styles.selected] : props.selected })} onClick={() => props.onClick(props.src)}>
				<img src={props.src} style={{width: props.width, height: props.height}}/>
			</Cutout>
    );
};

export default Meme;