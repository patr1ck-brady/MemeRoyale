import React from 'react';
import { Cutout } from "react95";

function Meme(props) {
    return (
			<Cutout style={{width: 'fit-content', height: 'fit-content'}}>
				<img src={props.src} style={{width: props.width, height: props.height}}/>
			</Cutout>
    );
};

export default Meme;