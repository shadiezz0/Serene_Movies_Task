import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface GenreForm {
    Name: StringEditor;
}

export class GenreForm extends PrefixedContext {
    static readonly formKey = 'Default.Genre';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!GenreForm.init)  {
            GenreForm.init = true;

            var w0 = StringEditor;

            initFormType(GenreForm, [
                'Name', w0
            ]);
        }
    }
}