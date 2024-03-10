import React from 'react'
import Link from 'next/link'

export function Header() {
  return (
    <header className="w-full py-4">
      <div className="container flex items-center justify-between px-4 md:px-6">
        <div className="flex items-center space-x-4">
          <Link className="flex items-center space-x-2" href="/">
            <HomeIcon className="h-6 w-6" />
            <span className="font-bold">Inicio</span>
          </Link>
        </div>
        <nav className="flex items-center space-x-4">
          <Link className="font-medium" href="/buscar">
            Buscar
          </Link>
          <Link className="font-medium" href="/reportar">
            Reportar
          </Link>
        </nav>
      </div>
    </header>
  )
}

function HomeIcon(props) {
  return (
    <svg
      {...props}
      xmlns="http://www.w3.org/2000/svg"
      width="24"
      height="24"
      viewBox="0 0 24 24"
      fill="none"
      stroke="currentColor"
      strokeWidth="2"
      strokeLinecap="round"
      strokeLinejoin="round"
    >
      <path d="m3 9 9-7 9 7v11a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2z" />
      <polyline points="9 22 9 12 15 12 15 22" />
    </svg>
  )
}
