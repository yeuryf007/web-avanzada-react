import React from 'react'
import Link from "next/link"
import { Label } from "@/components/ui/label"
import { Input } from "@/components/ui/input"
import { Button } from "@/components/ui/button"

export function NoEncontrada() {
  return (
    <div className="w-full max-w-2xl space-y-6">
        <div className="flex items-center space-x-4">
            <Link className="flex items-center space-x-2 text-blue-500" href="#">
            <CameraIcon className="w-6 h-6 text-blue-500" />
            <span className="font-serif font-semibold text-blue-500">Intenta otra foto</span>
            </Link>
        </div>
        <div className="grid items-center gap-0.5">
            <Label className="sr-only text-blue-500" htmlFor="photo">
            Subir Foto
            </Label>
            <Input accept="image/*" className="text-blue-500" id="photo" type="file" />
            <Button className="bg-blue-500 text-white hover:bg-blue-600">Subir Foto</Button>
        </div>
      </div>
  )
}

function CameraIcon(props) {
    return (
      (<svg
        {...props}
        xmlns="http://www.w3.org/2000/svg"
        width="24"
        height="24"
        viewBox="0 0 24 24"
        fill="none"
        stroke="currentColor"
        strokeWidth="2"
        strokeLinecap="round"
        strokeLinejoin="round">
        <path
          d="M14.5 4h-5L7 7H4a2 2 0 0 0-2 2v9a2 2 0 0 0 2 2h16a2 2 0 0 0 2-2V9a2 2 0 0 0-2-2h-3l-2.5-3z" />
        <circle cx="12" cy="13" r="3" />
      </svg>)
    );
  }