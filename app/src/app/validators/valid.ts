import { ValidatorFn, FormGroup, FormControl } from '@angular/forms';
import { DataService } from '../shared/services/data.service';


export function PasswordValidator(pass1: string, pass2: string): ValidatorFn {
    return (form: FormGroup): { [key: string]: any } | null => {
        if (form.controls[pass1].value != form.controls[pass2].value) {
            return { passError: 'no es la misma contrasena' }
        }
        return null;
    }
}
export class UsernameService {
mail=false
    constructor(private dataService: DataService) { }
  
    checkUserEmail(): ValidatorFn {
      return (control: FormControl): { [key: string]: any } | null => {
        const uname = control.value.trim();
       this.dataService.SingInCheckUser(uname).subscribe(
           res=> res=this.mail )
       if(this.mail==true)
          return { doubleusers: 'this username already exist' }
        
        else return null;
    }
      };
    }
  