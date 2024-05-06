import { GenreForm, GenreRow, GenreService } from '@/ServerTypes/Default';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('Serene_Movies_Task.Default.GenreDialog')
export class GenreDialog extends EntityDialog<GenreRow, any> {
    protected getFormKey() { return GenreForm.formKey; }
    protected getRowDefinition() { return GenreRow; }
    protected getService() { return GenreService.baseUrl; }

    protected form = new GenreForm(this.idPrefix);
}