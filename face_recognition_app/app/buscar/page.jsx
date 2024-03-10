import React from 'react'
import { Header } from "@/app/components/Header";
import { Buscar } from "@/components/component/Buscar";

const buscar = () => {
  return (
    <body>
      <Header />
      <main className="flex min-h-screen flex-col items-center justify-between p-24">
        <Buscar />
      </main>
    </body>
  )
}

export default buscar