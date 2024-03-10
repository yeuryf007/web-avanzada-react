import React from "react";
import { Header } from "@/app/components/Header";

export default function Home() {
  return (
    <body>
      <Header />
      <main className="flex min-h-screen flex-col items-center justify-between p-24">
        <div className="space-y-8">
        <h1 className="text-3xl font-bold">
          Una hermosa pagina para buscar personas desaparecidas :D
        </h1>
        </div>
      </main>
    </body>
  );
}
