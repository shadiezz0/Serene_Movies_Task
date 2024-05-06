import { MovieForm, MovieRow, MovieService } from '@/ServerTypes/Default';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('Serene_Movies_Task.Default.MovieDialog')
export class MovieDialog extends EntityDialog<MovieRow, any> {
    protected getFormKey() { return MovieForm.formKey; }
    protected getRowDefinition() { return MovieRow; }
    protected getService() { return MovieService.baseUrl; }

    protected form = new MovieForm(this.idPrefix);
}