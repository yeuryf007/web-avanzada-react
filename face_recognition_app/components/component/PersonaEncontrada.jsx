import React from 'react'
import { CardContent, Card } from "@/components/ui/card"

export function PersonaEncontrada() {
  return (
    <Card className="bg-blue-50 dark:bg-blue-900">
        <CardContent className="space-y-4">
          <div>
            <img
              alt="Foto"
              className="aspect-square rounded"
              height="100"
              src="/placeholder.svg"
              width="100" />
          </div>
          <div className="space-y-2">
            <h3 className="text-lg font-serif font-bold text-blue-500">Jane Doe</h3>
            <dl className="grid grid-cols-2 gap-1 text-sm text-blue-500">
              <div>Edad</div>
              <div>25-30</div>
              <div>Altura</div>
              <div>5'6"-5'8"</div>
              <div>Color de Ojos</div>
              <div>Marrón</div>
              <div>Color de Cabello</div>
              <div>Negro</div>
            </dl>
          </div>
        </CardContent>
      </Card>
  )
}