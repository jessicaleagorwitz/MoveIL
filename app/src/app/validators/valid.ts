import { ValidatorFn, FormControl, FormGroup } from '@angular/forms';


export function checkPass(pass1: string, pass2: string): ValidatorFn {
    return (form: FormGroup): { [key: string]: any } | null => {
        if (form.controls[pass1].value != form.controls[pass2].value) {
            return { passError: 'no es la misma contrasena' }
        }
        return null;
    }
}