import React from 'react'
import { Reportar } from "@/components/component/Reportar";
import { Header } from "@/app/components/Header";

const reportar = () => {
  return (
    <body>
      <Header />
      <main className="flex min-h-screen flex-col items-center justify-between p-24">
        <Reportar />
      </main>
    </body>
  )
}

export default reportar