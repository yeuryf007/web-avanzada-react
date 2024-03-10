import { Label } from "@/components/ui/label"
import { Input } from "@/components/ui/input"
import { Button } from "@/components/ui/button"

export function Buscar() {
  return (
    (<div className="mx-auto max-w-3xl p-6 space-y-6">
      <div className="space-y-2 text-center">
        <h1 className="text-3xl font-bold">Missing Person Identification</h1>
        <p className="text-gray-500 dark:text-gray-400">
          Upload a photo to identify if the person matches with a missing person
        </p>
      </div>
      <div className="flex flex-col gap-1.5">
        <Label htmlFor="photo">Select Photo</Label>
        <Input accept="image/*" id="photo" type="file" />
      </div>
      <Button>Identify</Button>
    </div>)
  );
}
