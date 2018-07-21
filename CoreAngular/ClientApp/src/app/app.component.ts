import { Component } from '@angular/core';
import { ModelsService } from './shared/models.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';
  constructor(private modelsService: ModelsService) {
    modelsService.loadModels();
  }
}
