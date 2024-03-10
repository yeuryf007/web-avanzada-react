import { Label } from "@/components/ui/label"
import { Input } from "@/components/ui/input"
import { Textarea } from "@/components/ui/textarea"
import { Button } from "@/components/ui/button"

export function Reportar() {
  return (
    (<div className="mx-auto max-w-3xl space-y-8 px-4">
      <div className="space-y-2">
        <h1 className="text-3xl font-bold">Reportar una persona desaparecida</h1>
        <p className="text-gray-500 dark:text-gray-400">
          Ingrese la información a continuación para reportar a una persona desaparecida.
        </p>
      </div>
      <div className="space-y-4">
        <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
          <div className="space-y-2">
            <Label htmlFor="name">Nombre</Label>
            <Input id="name" placeholder="Ingrese el nombre" required />
          </div>
          <div className="space-y-2">
            <Label htmlFor="age">Edad</Label>
            <Input id="age" placeholder="Ingrese la edad" required />
          </div>
          <div className="space-y-2">
            <Label htmlFor="gender">Género</Label>
            <select className="flex h-10 w-full items-center justify-between rounded-md border border-gray-200 bg-white px-3 py-2 text-sm ring-offset-white placeholder:text-gray-500 focus:outline-none focus:ring-2 focus:ring-gray-950 focus:ring-offset-2 disabled:cursor-not-allowed disabled:opacity-50 [&>span]:line-clamp-1 dark:border-gray-800 dark:bg-gray-950 dark:ring-offset-gray-950 dark:placeholder:text-gray-400 dark:focus:ring-gray-300"
             id="gender" required>
              <option>Elegir</option>
              <option>Femenino</option>
              <option>Masculino</option>
              <option>Otro</option>
            </select>
          </div>
          <div className="space-y-2">
            <Label htmlFor="height">Altura</Label>
            <Input id="height" placeholder="Ingrese la altura" required />
          </div>
          <div className="space-y-2">
            <Label htmlFor="weight">Peso</Label>
            <Input id="weight" placeholder="Ingrese el peso" required />
          </div>
          <div className="space-y-2">
            <Label htmlFor="last-location">Última ubicación conocida</Label>
            <Input
              id="last-location"
              placeholder="Ingrese la última ubicación conocida"
              required />
          </div>
          <div className="space-y-2">
            <Label htmlFor="additional-details">Detalles adicionales</Label>
            <Textarea
              className="min-h-[100px]"
              id="additional-details"
              placeholder="Ingrese cualquier detalle adicional" />
          </div>
          <div className="space-y-2">
            <Label htmlFor="photos">Fotos</Label>
            <Input accept="image/*" id="photos" multiple type="file" />
            <p className="text-sm text-gray-500 dark:text-gray-400">
              Puede cargar uno o varios archivos de fotos. Formatos aceptados: jpg, png, gif. Tamaño máximo del archivo:
              10MB.
            </p>
          </div>
        </div>
        <Button>Enviar</Button>
      </div>
    </div>)
  );
}