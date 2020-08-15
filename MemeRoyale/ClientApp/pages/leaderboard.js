import React from "react";
import Head from "next/head";
import styles from "../styles/Home.module.css";
import { createGlobalStyle, ThemeProvider } from "styled-components";
import original from "react95/dist/themes/original";
import {
  Table,
  TableBody,
  TableHead,
  TableRow,
  TableHeadCell,
  TableDataCell,
  Window,
  WindowHeader,
  WindowContent,
} from "react95";

export default function Home() {
  return (
      <ThemeProvider theme = {original}>
    <Window style={{ width: '60vw'}}>
      <WindowHeader>🤣{'  '} MemeRoyale.app - Leaderboard</WindowHeader>
      <WindowContent>
        <Table>
          <TableHead>
            <TableRow head>
              <TableHeadCell>Avatar</TableHeadCell>
              <TableHeadCell>Name</TableHeadCell>
              <TableHeadCell>Score</TableHeadCell>
            </TableRow>
          </TableHead>
          <TableBody>
            <TableRow>
              <TableDataCell style={{ textAlign: "center" }}>
                <span role="img" aria-label="LEAF">
                  🌿
                </span>
              </TableDataCell>
              <TableDataCell>Bulbasaur</TableDataCell>
              <TableDataCell>64</TableDataCell>
            </TableRow>
            <TableRow>
              <TableDataCell style={{ textAlign: "center" }}>
                <span role="img" aria-label="fire">
                  🔥
                </span>
              </TableDataCell>
              <TableDataCell>Charizard</TableDataCell>
              <TableDataCell>209</TableDataCell>
            </TableRow>
            <TableRow>
              <TableDataCell style={{ textAlign: "center" }}>
                <span role="img" aria-label="lightning">
                  ⚡
                </span>
              </TableDataCell>
              <TableDataCell>Pikachu</TableDataCell>
              <TableDataCell>82</TableDataCell>
            </TableRow>
          </TableBody>
        </Table>
      </WindowContent>
    </Window>
    </ThemeProvider>
  );
}
